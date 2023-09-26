namespace SummerEditor.Models
{
    public class SummerNotesModel
    {
        
        public SummerNotesModel(string idEditor,bool loadLibrary=true)
        {
            IDEditor=idEditor;
            LoadLibrary=loadLibrary;
        }
        public string IDEditor { get; set; }
        public bool LoadLibrary { get; set; }
        public int Height { get; set; }=200;
        public string Toolbar { get; set; }= @"[
          ['style', ['style']],
          ['font', ['bold', 'underline', 'clear']],
          ['color', ['color']],
          ['para', ['ul', 'ol', 'paragraph']],
          ['table', ['table']],
          ['insert', ['link', 'picture', 'video']],
          ['view', ['fullscreen', 'codeview', 'help']]
        ]";
   
    }
}