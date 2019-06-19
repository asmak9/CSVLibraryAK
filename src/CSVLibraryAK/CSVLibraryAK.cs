//-----------------------------------------------------------------------
// <copyright file="CSVLibraryAK.cs" company="None">
//     Copyright (c) Allow to distribute this code and utilize this code for personal or commercial purpose.
// </copyright>
// <author>Asma Khalid</author>
//-----------------------------------------------------------------------

namespace CSVLibraryAK
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Web;
    using Resources.Constants;

    /// <summary>
    /// CSV library class.
    /// </summary>
    public class CSVLibraryAK
    {
        #region Import Data method.

        /// <summary>
        /// Import Data method.
        /// </summary>
        /// <param name="srcFilePath">Source file path parameter</param>
        /// <param name="hasHeader">Has header parameter</param>
        /// <returns>Returns CSV data as data table</returns>
        public static DataTable Import(string srcFilePath, bool hasHeader)
        {
            // Initilization
            DataTable datatable = new DataTable();
            StreamReader sr = null;

            try
            {
                // Creating data table without header.
                using (sr = new StreamReader(new FileStream(srcFilePath, FileMode.Open, FileAccess.Read)))
                {
                    // Initialization.
                    string line = string.Empty;
                    string[] headers = sr.ReadLine().Split(',');
                    DataRow dr = datatable.NewRow();

                    // Preparing header.
                    for (int i = 0; i < headers.Length; i++)
                    {
                        // Verification.
                        if (hasHeader)
                        {
                            // Setting.
                            datatable.Columns.Add(headers[i]);
                        }
                        else
                        {
                            // Setting.
                            datatable.Columns.Add(Strings.COL_HEADER_1 + i);
                            dr[i] = headers[i];
                        }
                    }

                    // Verification.
                    if (!hasHeader)
                    {
                        // Adding.
                        datatable.Rows.Add(dr);
                    }

                    // Adding data.
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Initialization.
                        string[] rows = line.Split(',');
                        dr = datatable.NewRow();

                        // Verification
                        if (string.IsNullOrEmpty(line))
                        {
                            // Info.
                            continue;
                        }

                        // Adding row.
                        for (int i = 0; i < headers.Length; i++)
                        {
                            // Setting.
                            dr[i] = rows[i];
                        }

                        // Adding.
                        datatable.Rows.Add(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                // Info.
                throw ex;
            }
            finally
            {
                // Closing.
                sr.Dispose();
                sr.Close();
            }

            // Info.
            return datatable;
        }

        #endregion

        #region Export Data method.

        /// <summary>
        /// Export Data method.
        /// </summary>
        /// <param name="destFilePath">Destination file path parameter</param>
        /// <param name="dataTable">Data table parameter</param>
        /// <returns>Returns - True if save successfully</returns>
        public static bool Export(string destFilePath, DataTable dataTable)
        {
            // Initilization
            bool isSuccess = false;
            StreamWriter sw = null;

            try
            {
                // Initialization.
                StringBuilder stringBuilder = new StringBuilder();

                // Saving Column header.
                stringBuilder.Append(string.Join(",", dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToList()) + "\n");

                // Saving rows.
                dataTable.AsEnumerable().ToList<DataRow>().ForEach(row => stringBuilder.Append(string.Join(",", row.ItemArray) + "\n"));

                // Initialization.
                string fileContent = stringBuilder.ToString();
                sw = new StreamWriter(new FileStream(destFilePath, FileMode.Create, FileAccess.Write));

                // Saving.
                sw.Write(fileContent);

                // Settings.
                isSuccess = true;
            }
            catch (Exception ex)
            {
                // Info.
                throw ex;
            }
            finally
            {
                // Closing.
                sw.Flush();
                sw.Dispose();
                sw.Close();
            }

            // Info.
            return isSuccess;
        }

        #endregion
    }
}