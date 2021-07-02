using System.Collections.Generic;
using System.Drawing;

namespace TextEditor
{
    class Controller
    {
        Model model;

        public Controller()
        {
            model = new Model();
        }

        public int GetRedoAmount()
        {
            return model.GetRedoAmount();
        }

        public int GetUndoAmount()
        {
            return model.GetUndoAmount();
        }

        public void AddRedoState(string state)
        {
            model.AddRedoState(state);
        }

        public void AddUndoState(string state)
        {
            model.AddUndoState(state);
        }

        public string Redo()
        {
            return model.Redo();
        }

        public string Undo()
        {
            return model.Undo();
        }

        public Dictionary<string, Color> GetDictionary()
        {
            return model.GetDictionary();
        }

        public void SetDistionary(Dictionary<string, Color> newDictionary)
        {
            model.SetDistionary(newDictionary);
        }

        public Color GetTextColor()
        {
            return model.GetTextColor();
        }

        public void SetTextColor(Color color)
        {
            model.SetTextColor(color);
        }

        public Font GetFont()
        {
            return model.GetFont();
        }

        public Color GetBackColor()
        {
            return model.GetBackColor();
        }

        public Dictionary<string, Color> GetRegex()
        {
            return model.GetRegex();
        }

        public void SetRegex(Dictionary<string, Color> newRegex)
        {
            model.SetRegex(newRegex);
        }

        public string GetFileName()
        {
            return model.GetFileName();
        }

        public void SetFileName(string path)
        {
            model.SetFileName(path);
        }
    }
}
