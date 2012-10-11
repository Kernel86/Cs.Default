using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Novak.StudentMaintenance.Utilities.PL
{
    public class CFile
    {
    // Private Properties
        private string _filename;
        private string _location;
    
    // Public Properties
        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

    // Constructors
        public CFile()
        {

        }

        public CFile(string sFilename)
        {
            _filename = sFilename;
        }

    // Public Methods
        public bool Open()
        {
            return true;
        }

        public void Close()
        {

        }

        public string Read()
        {
            try
            {
                StreamReader oReader = File.OpenText(_filename);
                string sContents = oReader.ReadToEnd();
                oReader.Close();
                oReader.Dispose();
                oReader = null;

                return sContents;
            }
            catch (FileNotFoundException)
            {
                throw new Exception("File not found.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Write(string sContents)
        {
            try
            {
                StreamWriter oWriter = File.AppendText(_filename);
                oWriter.WriteLine(sContents);
                oWriter.Close();
                oWriter.Dispose();
                oWriter = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete()
        {
            try
            {
                if (File.Exists(_filename))
                    File.Delete(_filename);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
