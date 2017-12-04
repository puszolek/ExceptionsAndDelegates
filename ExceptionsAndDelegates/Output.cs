using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionsAndDelegates
{
    public class Output
    {
        public static void ShowDialogBox(string s)
        {
            MessageBox.Show(s);
        }

        public static void SaveToFile(string s)
        {
            string filename = "C:\\Users\\student.SL228-03\\Desktop\\results.txt";

            FileStream fileStream;
            StreamWriter streamWriter;
            fileStream = new FileStream(filename, FileMode.Append);
            streamWriter = new StreamWriter(fileStream);

            try
            {
                //streamWriter = File.AppendText(filename);
                streamWriter.WriteLine(s);
            }
            catch (IOException ex)
            {
                ShowDialogBox(ex.Message);
            }
            catch (Exception ex)
            {
                ShowDialogBox(ex.Message);
            }
            finally
            {
                if (streamWriter != null)
                    streamWriter.Dispose();
                fileStream.Close();
            }
        }
    }
}
