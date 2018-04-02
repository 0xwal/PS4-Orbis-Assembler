using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orbis_Assembler
{
    static class Helper
    {
        public static void Cmd(string fileName, string arg, out string output)
        {
            string workingDir = new FileInfo(fileName).DirectoryName;
            Process p = new Process
            {
                StartInfo =
                {
                    Arguments = arg,
                    CreateNoWindow = true,
                    FileName = fileName,
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    WorkingDirectory = workingDir,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                }
            };
            p.Start();
            while (!p.HasExited);
            output = p.StandardError.ReadToEnd() + p.StandardOutput.ReadToEnd();
        }
        public static void LoadFile(string fileName, string dir = null)
        {
            string filePath = Assembly.GetExecutingAssembly().GetName().Name.Replace(" ", "_") + "." + "Files" + "." + fileName;
            using (BinaryReader bn = new BinaryReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(filePath)))
            {
                byte[] fileBuffer = bn.ReadBytes((int)bn.BaseStream.Length);
                File.WriteAllBytes(dir + fileName, fileBuffer);
            }
        }

        public static string OnlyHexValues(string hex)
        {
            hex = hex.Replace("0x", "");
            var values = Regex.Matches(hex, "[a-fA-F0-9]+");
            return values.Cast<object>().Aggregate("", (current, item) => current + item);
        }
        public static byte[] Hex(string hex)
        {
            if (hex == "")
                return null;
            hex = OnlyHexValues(hex);
            hex = (((hex.Length % 2) == 1) ? "0" : "") + hex;
            return (from x in Enumerable.Range(0, hex.Length)
                    where (x % 2) == 0
                    select Convert.ToByte(hex.Substring(x, 2), 0x10)).ToArray();
        }
        public static void SafeDelete(string file)
        {
            if (File.Exists(file))
                File.Delete(file);
        }
        public static void CopyAsCsharp(string input)
        {
            var opBox = input.Replace(" ", "");

            string res = @"byte[] buffer = { " +
                new Regex("(, )$").Replace(string.Join("", from c in Enumerable.Range(0, opBox.Length)
                                                           where (c % 2) == 0
                                                           select "0x" + opBox.Substring(c, 2) + ", "), "")
                + " };";
            Clipboard.SetDataObject(res);
        }
    }
}
