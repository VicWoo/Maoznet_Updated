using System;
using System.Collections.Generic;
using System.Text;
using Network.Matrices;
using System.IO;
using System.Windows.Forms;

namespace Network.IO
{
    public sealed class MatrixWriter
    {
        private MatrixWriter() { }

        public static void WriteMatrixToMatrixFile(Matrix m, string filename)
        {
            WriteMatrixToMatrixFile(m, filename, false, true, true);
        }
        public static void WriteMatrixToMatrixFile(Matrix m, string filename, bool overwrite)
        {
            WriteMatrixToMatrixFile(m, filename, overwrite, true, true);
        }
        public static void WriteMatrixToMatrixFile(Matrix m, string filename,
            bool overwrite, bool writeNetworkId, bool writeColLabels)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename, !overwrite))
                {
                    if (writeNetworkId)
                        //writer.WriteLine(m.NetworkIdIndex);
                        // Yushan
                        writer.WriteLine(m.ActualNetworkIdStr);

                    if (writeColLabels)
                    {
                        // writer.Write(',');
                        // writer.WriteLine(m.ColLabels.ToString());
                        for (int j = 0; j < m.Cols; ++j)
                        {
                            if (String.Equals(m.ColLabels[j], "Network ID") || String.Equals(m.ColLabels[j], "Year")) { }
                            else
                            {
                                writer.Write(',');
                                writer.Write(m.ColLabels[j]);
                            }
                        }
                        writer.WriteLine();
                    }

                    for (int i = 0; i < m.Rows; ++i)
                    {
                        writer.Write(m.RowLabels[i]);
                        for (int j = 0; j < m.Cols; ++j)
                        {
                            if (String.Equals(m.ColLabels[j], "Network ID") || String.Equals(m.ColLabels[j], "Year")) ;
                            else
                            {
                                writer.Write(',');
                                writer.Write(m[i, j]);
                            }
                        }
                        writer.WriteLine();
                    }
                    // Yushan
                    writer.Flush();
                    writer.Close();
                }
            } catch (Exception e)
            {
                MessageBox.Show("Error in saving matrix file! " + e.Message);
            }
        }

        public static void WriteMatrixToDyadicFile(Matrix m, string filename)
        {
            WriteMatrixToDyadicFile(m, filename, false, true, true);
        }
        public static void WriteMatrixToDyadicFile(Matrix m, string filename, bool overwrite)
        {
            WriteMatrixToDyadicFile(m, filename, overwrite, true, true);
        }
        public static void WriteMatrixToDyadicFile(Matrix m, string filename,
            bool overwrite, bool writeNetworkId, bool writeColLabels)
        {
            using (StreamWriter writer = new StreamWriter(filename, !overwrite))
            {
                for (int i = 0; i < m.Rows; ++i)
                {
                    for (int j = 0; j < m.Cols; ++j)
                    {
                        //string line = m.NetworkIdIndex + "," + m.RowLabels[i].ToString() + ","; // modified
                        string line = m.ActualNetworkIdStr + "," + m.RowLabels[i].ToString() + ",";
                        line += m.RowLabels[j].ToString() + "," + m[i, j].ToString();
                        writer.WriteLine(line);
                    }
                }
            }
        }

        public static void WriteDyadicHeader(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                writer.WriteLine("\"Network ID\",\"Row\",\"Column\",\"value\"");
            }
        }

        public static void WriteVectorToVectorFile(Vector v, string filename)
        {
            WriteMatrixToMatrixFile(v, filename, false);
        }
        public static void WriteVectorToVectorFile(Vector v, string filename, bool overwrite)
        {
            using (StreamWriter writer = new StreamWriter(filename, !overwrite))
            {
                for (int i = 0; i < v.Size; ++i)
                {
                    //writer.WriteLine("{0},{1},{2}", v.NetworkIdIndex, v.Labels[i], v[i]);
                    writer.WriteLine("{0},{1},{2}", v.ActualNetworkIdStr, v.Labels[i], v[i]);
                }
            }
        }
    }
}
