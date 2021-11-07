using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilesReadWrite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NoteBookController : ControllerBase
    {
        NoteBook jeffTheNoteBoy = new NoteBook();
        [HttpPost]
        public void TakeNote(string note)
        {
            jeffTheNoteBoy.TakeNote(note);
        }
        [HttpGet]
        public string[] GetAllNotes()
        {
            return jeffTheNoteBoy.GetAllNotes();
        }
    }
}
