using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Manning.MyPhotoAlbum
{
    public class AlbumStorageException : Exception
    {
        public AlbumStorageException() : base() { }
        public AlbumStorageException(string msg) : base(msg) { }
        public AlbumStorageException(string msg,Exception inner) : base(msg, inner) { }

    }
    public static class AlbumStorage
    {
        static private int CurrentVersion = 91;
        static public void WriteAlbum(PhotoAlbum album,string path,string password)
        {
            StreamWriter sw = null;
            try
            {
                if (password == null || password.Length == 0)
                {
                    sw = new StreamWriter(path);
                    sw.WriteLine(CurrentVersion.ToString());
                }
                else
                {
                    // Create CryptoWriter to use as StreamWriter
                    CryptoWriter cw = new CryptoWriter(path, password);
                    cw.WriteUnencryptedLine(CurrentVersion.ToString() + 'e');
                    cw.WriteLine(password);
                    sw = cw;
                }
                //Save album properties
                sw.WriteLine(album.Title);
                sw.WriteLine(album.PhotoDescriptor.ToString());

                // Storage each photo separately
                foreach (Photograph photograph in album)
                {
                    WritePhoto(sw, photograph);
                }

                // Reset changed after all photos written
                album.HasChanged = false;
            }
            catch (UnauthorizedAccessException uax)
            {

                throw new AlbumStorageException("Unable to access album " + path,uax);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }
        static public void WriteAlbum(PhotoAlbum album,string path)
        {
            WriteAlbum(album, path, null);
        }
        private static void WritePhoto(StreamWriter sw, Photograph p)
        {
            sw.WriteLine(p.FileName);
            sw.WriteLine(p.Caption != null ? p.Caption : "");
            sw.WriteLine(p.DateTaken.ToString());
            sw.WriteLine(p.Photographer != null?p.Photographer:"");
            sw.WriteLine(p.Notes != null ? p.Notes : "");

        }

        static public PhotoAlbum ReadAlbum(string path,string password)
        {
            StreamReader sr = null;
            try
            {
                string version;
                if (password == null || password.Length == 0)
                {
                    sr = new StreamReader(path);
                    version = sr.ReadLine();
                    if (version.EndsWith("e"))
                    {
                        throw new AlbumStorageException("A password is required to open the album");
                    }
                }
                else
                {
                    // Create CryptoReader to use as StreamReader 
                    CryptoReader cr = new CryptoReader(path, password);
                    version = cr.ReadUnercryptedLine();
                    if (!version.EndsWith("e"))
                    {
                        // Decryption not required
                        cr.Close();
                        sr = new StreamReader(path);
                        version = sr.ReadLine();
                    }
                    else
                    {
                        string checkLine = cr.ReadLine();
                        if (checkLine != password)
                        {
                            throw new AlbumStorageException("The given password is not valid");
                        }
                        sr = cr;
                    }
                }
                 
                PhotoAlbum album = new PhotoAlbum();
                switch (version)
                {
                    case "63":
                        ReadAlbumV63(sr, album);
                        break;
                    case "91":
                    case "91e":
                        ReadAlbumV91(sr, album);
                        break;
                    default:
                        throw new AlbumStorageException("Unrecongnized album version"); 
                }
                album.HasChanged = false;
                return album;
            }
            catch (FileNotFoundException fnx)
            {

                throw new AlbumStorageException("Uable to read album "+path,fnx);
            }
            finally
            {
                if (sr!=null)
                {
                    sr.Close();
                }
            }
        }

        static public PhotoAlbum ReadAlbum(string path)
        {
            return ReadAlbum(path, null);
        }
        private static void ReadAlbumV91(StreamReader sr, PhotoAlbum album)
        {
            // Read album properties
            album.Title = sr.ReadLine();
            string enumVal = sr.ReadLine();
            album.PhotoDescriptor = (PhotoAlbum.DescriptorOption)Enum.Parse(typeof(PhotoAlbum.DescriptorOption), enumVal);

            // Version 91 finishes with Version 63
            ReadAlbumV63(sr, album);
        }

        private static void ReadAlbumV63(StreamReader sr, PhotoAlbum album)
        {
            // Read each photo into album
            Photograph p;
            do
            {
                p = ReadAlbumV63(sr);
                if (p != null)
                {
                    album.Add(p);
                }
            } while (p != null);
        }

        private static Photograph ReadAlbumV63(StreamReader sr)
        {
            // Presume at the start of photo
            string file = sr.ReadLine();
            if (file == null  || file.Length == 0)
            {
                return null;
            }

            // File not null , should file photo
            Photograph p = new Photograph(file);
            p.Caption = sr.ReadLine();
            p.DateTaken = DateTime.Parse(sr.ReadLine());
            p.Photographer = sr.ReadLine();
            p.Notes = sr.ReadLine();

            return p;
        }

        static public bool IsEncrypted(string path)
        {
            StreamReader sr = null;
            try
            {
                using (sr= new StreamReader(path))
                {
                    string version = sr.ReadLine();
                    return version.EndsWith("e");
                }
            }
            catch (FileNotFoundException fnx)
            {

                throw new AlbumStorageException("Unable to find album "+path,fnx);
            }
        }
    }
}
