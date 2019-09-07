using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Collections.Specialized;

namespace Manning.MyPhotoAlbum
{
    public class AlbumManager
    {

        #region StaticArea
        /// <summary>
        /// 静态变量/静态函数定义
        /// </summary>
        static private string _defaultPath;
        static public string DefaultPath
        {
            get { return _defaultPath; }
            set { _defaultPath = value; }
        }
        static AlbumManager()
        {
            _defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\Albums";
        }
        /// <summary>
        /// 创建一个占位符
        /// 这个方法用于检查一个相册是否已存在
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static public bool AlbumExists(string name)
        {
            //TODO: implement AlbumExists method
            // return false;
            return File.Exists(name);
        }
        #endregion
        #region InstanceVariant
        private int _pos = -1;
        private string _name = string.Empty;
        private PhotoAlbum _album;
        private string _password;
        private StringCollection _photographers = null;
        public StringCollection Photographers
        {
            get
            {
                if (Album.HasChanged || _photographers == null)
                {
                    _photographers = new StringCollection();
                    foreach (Photograph p in Album)
                    {
                        // Make sure we add each person only once 
                        string person = p.Photographer;
                        if (person != null &&
                            person.Length > 0 &&
                            !_photographers.Contains(person))
                        {
                            _photographers.Add(person);
                        }
                    }
                }
                return _photographers;
            }
        }
        public AlbumManager()
        {
            _album = new PhotoAlbum();
        }

        public AlbumManager(string name) : this()
        {
            _name = name;

            _album = AlbumStorage.ReadAlbum(name);
            if (Album.Count > 0)
            {
                Index = 0;
            }
            // TODO: load the album
            // throw new NotImplementedException();
        }

        public AlbumManager(string name,string pwd) : this()
        {
            _name = name;
            _album = AlbumStorage.ReadAlbum(name, pwd);
            PassWord = pwd;
        }

        public PhotoAlbum Album
        {
            get { return _album; }
        }

        public string FullName
        {
            get { return _name; }
            private set { _name = value; }
        }
        public string PassWord
        {
            get { return _password; }
            set { _password = value; }
        }
        public string ShortName
        {
            get
            {
                if (String.IsNullOrEmpty(FullName))
                {
                    return null;
                }
                else
                {
                    return Path.GetFileNameWithoutExtension(FullName);
                }
            }
        }
        public int Index
        {
            get
            {
                int count = Album.Count;
                if (_pos >= count)
                {
                    _pos = count - 1;
                }
                return _pos;
            }
            set
            {
                if (value < 0 || value >= Album.Count)
                {
                    throw new IndexOutOfRangeException("The given index is out of bounds");
                }
                _pos = value;
            }
        }
        public Photograph Current
        {
            get
            {
                if (Index < 0 || Index >= Album.Count)
                {
                    return null;
                }
                return Album[_pos];
            }
        }

        public Bitmap CurrentImage
        {
            get
            {
                if (Current == null)
                {
                    return null;
                }
                return Current.Image;
            }
        }
        /// <summary>
        /// 为一些最终的Save方法创建占位符
        /// </summary>
        public void Save()
        {
            // ToDo:Implement Save method
            // throw new NotImplementedException();
            if (FullName == null)
            {
                throw new InvalidOperationException("Unable to save album with no name");
            }
            AlbumStorage.WriteAlbum(Album, FullName,PassWord);
        }
        public void Save(string name,bool overwrite)
        {
            //ToDo: Implement Save(name) method
            //throw new NotImplementedException();
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (name != FullName && AlbumExists(name) && !overwrite)
            {
                throw new ArgumentException("An album with this name exists");
            }
            AlbumStorage.WriteAlbum(Album, name,PassWord);
            FullName = name;
        }
        /// <summary>
        /// 安全地移动到相册的下一个位置
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if (Index >= Album.Count)
            {
                return false;
            }
            Index++;
            return true;
        }
        /// <summary>
        /// 安全地移动到相册的上一个位置
        /// </summary>
        /// <returns></returns>
        public bool MovePrev()
        {
            if (Index <= 0)
            {
                return false;
            }
            Index--;
            return true;
        }
        #endregion

        public void MoveItemBackward(int index)
        {
            if (index <= 0 || index >= Album.Count)
            {
                throw new IndexOutOfRangeException();
            }

            // Remove photo and reinsert at prior position
            Photograph photo = Album[index];
            Album.RemoveAt(index);
            Album.Insert(index - 1, photo);
        }
        public void MoveItemForward(int index)
        {
            if (index < 0 || index > Album.Count -1)
            {
                throw new IndexOutOfRangeException();
            }

            // Remove photo and reinsert at subsequent pos
            Photograph photo = Album[index];
            Album.RemoveAt(index);
            Album.Insert(index + 1, photo);
        }
    }
}
