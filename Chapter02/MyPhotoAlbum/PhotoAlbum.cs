using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace Manning.MyPhotoAlbum
{
    public class PhotoAlbum:Collection<Photograph>,IDisposable
    {
        public enum DescriptorOption
        {
            FileName,Caption,DateTaken
        }
        private string _title;
        public string Title
        {
            get { return _title; }
            set
            { _title = value;
                HasChanged = true;
            }
        }
        private DescriptorOption _descrtiptor;
        public DescriptorOption PhotoDescriptor
        {
            get { return _descrtiptor; }
            set
            {
                _descrtiptor = value;
                HasChanged = true;
            }
        }
        private void ClearSettings()
        {
            _title = null;
            _descrtiptor = DescriptorOption.Caption;
        }
        private bool _hasChanged = false;
        public bool HasChanged
        {
            get
            {
                if (_hasChanged)
                {
                    return true;
                }
                foreach (Photograph p in this)
                {
                    if (p.HasChanged)
                    {
                        return true;
                    }
                }
                return false;
            }
            internal set
            {
                _hasChanged = value;
                if (value == false)
                {
                    foreach (Photograph p in this)
                    {
                        p.HasChanged = false;
                    }
                }
            }
        }

        public PhotoAlbum()
        {
            ClearSettings();
        }
        public Photograph Add(string fileName)
        {
            Photograph p = new Photograph(fileName);
            base.Add(p);
            return p;
        }

        public void Dispose()
        {
            ClearSettings();
            foreach (Photograph photogra in this)
            {
                photogra.Dispose();
            }
        }

        protected override void ClearItems()
        {
            if (Count > 0)
            {
                Dispose();
                base.ClearItems();
                HasChanged = true;
            }
        }

        protected override void InsertItem(int index, Photograph item)
        {
            base.InsertItem(index, item);
            HasChanged = true;
        }

        protected override void RemoveItem(int index)
        {
            Items[index].Dispose();
            base.RemoveItem(index);
            HasChanged = true;
        }
        protected override void SetItem(int index, Photograph item)
        {
            base.SetItem(index, item);
            HasChanged = true;
        }

        public string GetDescription(Photograph photo)
        {
            switch (PhotoDescriptor)
            {
                case DescriptorOption.FileName:
                    return photo.FileName;
                case DescriptorOption.Caption:
                    return photo.Caption; 
                case DescriptorOption.DateTaken:
                    return photo.DateTaken.ToShortDateString();
            }
            throw new ArgumentException("Unrecognized photo descriptor option."); 
        }

        public string GetDescription(int index)
        {
            return GetDescription(this[index]);
        }

        private string _pwd;
        public string Password
        {
            get { return _pwd; }
            set { _pwd = value; }
        }
        public string GetDescriptorFormat()
        {
            switch (PhotoDescriptor)
            {
                case DescriptorOption.FileName:
                    return "f";
                case DescriptorOption.Caption:
                    return "c";
                case DescriptorOption.DateTaken:
                    return "d";
                default:
                    return "f";
            }
        }
    }
}
