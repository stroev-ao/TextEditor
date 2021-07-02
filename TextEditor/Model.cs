using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace TextEditor
{
    class Model
    {
        Dictionary<string, Color> dMain, dRegex;
        Color textColor, backColor;
        Font font;
        string filePath = null;
        List<string> undo;
        List<string> redo;

        public Model()
        {
            undo = new List<string>();
            redo = new List<string>();

            font = new Font("Arial", 12);
            textColor = Color.Black;
            backColor = Color.Gainsboro;
            dMain = new Dictionary<string, Color>();
            dRegex = new Dictionary<string, Color>();

            dMain.Add("[$", Color.Red);
            dMain.Add("]", Color.Red);
            dMain.Add("+", Color.DimGray);
            dMain.Add("-", Color.DimGray);
            dMain.Add("/", Color.DimGray);
            dMain.Add("*", Color.DimGray);
            dMain.Add("!=", Color.DimGray);
            dMain.Add("<>", Color.DimGray);
            dMain.Add(">=", Color.DimGray);
            dMain.Add("<=", Color.DimGray);
            dMain.Add("=", Color.DimGray);
            dMain.Add(">", Color.DimGray);
            dMain.Add("<", Color.DimGray);
            dMain.Add("like", Color.DimGray);

            dRegex.Add(@"(\(#[a-zA-Z\.\[\]\(\)#0-9]+\))", Color.Green);
            dRegex.Add(@"(\'[\w\d]+\')", Color.Firebrick);
            dRegex.Add(@"(\scase\s)", Color.Blue);
            dRegex.Add(@"(\swhen\s?)", Color.Blue);
            dRegex.Add(@"(\sthen\s)", Color.Blue);
            dRegex.Add(@"(\selse\s)", Color.Blue);
            dRegex.Add(@"(\send\s)", Color.Blue);
            dRegex.Add(@"(\sor\s)", Color.Blue);
            dRegex.Add(@"(\sand\s)", Color.Blue);
            dRegex.Add(@"(\sfor\s?)", Color.Fuchsia);
            dRegex.Add(@"(\sto\s)", Color.Fuchsia);
            dRegex.Add(@"(\sstep\s)", Color.Fuchsia);
            dRegex.Add(@"(\sdo\s?)", Color.Fuchsia);

            dRegex.Add(@"(\spow\s?)", Color.Olive);
            dRegex.Add(@"(\smin\s?)", Color.Olive);
            dRegex.Add(@"(\smax\s?)", Color.Olive);
            dRegex.Add(@"(\ssum\s?)", Color.Olive);
            dRegex.Add(@"(\sarg\s?)", Color.Olive);
            dRegex.Add(@"(\sconcat\s?)", Color.Olive);
            dRegex.Add(@"(\ssubstring\s?)", Color.Olive);
        }

        public int GetRedoAmount()
        {
            return redo.Count;
        }

        public int GetUndoAmount()
        {
            return undo.Count;
        }

        public void AddRedoState(string state)
        {
            if (redo.Count < 100)
                redo.Add(state);
        }

        public void AddUndoState(string state)
        {
            if (undo.Count < 100)
            {
                undo.Add(state);
                //redo.Clear();
            }
            else
            {
                undo.RemoveAt(0);
                undo.Add(state);
            }
        }

        public string Redo()
        {
            if (redo.Count == 0)
                return null;

            int lastIndex = redo.Count - 1;
            string text = redo[lastIndex];
            redo.RemoveAt(lastIndex);
            return text;
        }

        public string Undo()
        {
            if (undo.Count == 0)
                return null;

            int lastIndex = undo.Count - 1;
            string text = undo[lastIndex];
            undo.RemoveAt(lastIndex);
            return text;
        }

        public Dictionary<string, Color> GetDictionary()
        {
            return dMain;
        }

        public void SetDistionary(Dictionary<string, Color> newDictionary)
        {
            dMain.Clear();

            if (newDictionary == null || newDictionary.Count == 0)
                return;

            for (int i = 0; i < newDictionary.Count; i++)
                dMain.Add(newDictionary.ElementAt(i).Key, newDictionary.ElementAt(i).Value);
        }

        public Dictionary<string, Color> GetRegex()
        {
            return dRegex;
        }

        public void SetRegex(Dictionary<string, Color> newRegex)
        {
            dRegex.Clear();

            if (newRegex == null || newRegex.Count == 0)
                return;

            for (int i = 0; i < newRegex.Count; i++)
                dRegex.Add(newRegex.ElementAt(i).Key, newRegex.ElementAt(i).Value);
        }

        public Color GetTextColor()
        {
            return textColor;
        }

        public void SetTextColor(Color color)
        {
            textColor = color;
        }

        public Color GetBackColor()
        {
            return backColor;
        }

        public Font GetFont()
        {
            return font;
        }

        public string GetFileName()
        {
            return filePath;
        }

        public void SetFileName(string path)
        {
            filePath = path;
        }
    }
}
