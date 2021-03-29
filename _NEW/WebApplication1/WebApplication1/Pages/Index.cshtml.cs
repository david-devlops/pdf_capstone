﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;


namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        /*        private readonly ILogger<IndexModel> _logger;
        */
        //private readonly AudioContext db;
        // public IndexModel(AudioContext db) => this.db = db;
        // public List<AudioModel> Audios { get; set; } = new List<AudioModel>();

        private readonly DatabaseFileContext db1;

        public IndexModel(DatabaseFileContext db1) => this.db1 = db1;

        public IHostingEnvironment hostingEnvironment;
        public List<DatabaseFile> FileDatabase { get; set; } = new List<DatabaseFile>();


        /*
        public IndexModel(IHostingEnvironment environment)
        {
            this.hostingEnvironment = environment;
        }
        */
        
        public async Task OnGetAsync()
        {
            //Audios = await db.Audios.ToListAsync();
            FileDatabase = await db1.Files.ToListAsync();
            //FileDatabase = await db1.Files.AddAsync();
            //await db1.SaveChangesAsync();
        }

        public void OnPost(IFormFile formFile)
        {
            
            BinaryReader br = new BinaryReader(formFile.OpenReadStream());
            byte[] buffer = br.ReadBytes((int)formFile.Length);
            DatabaseFile uploadedFile = new DatabaseFile();
            uploadedFile.FileName = formFile.FileName;
            uploadedFile.ContentType = formFile.ContentType;
            uploadedFile.FileID = 2;
            uploadedFile.FileSize = (int)formFile.Length;
            uploadedFile.FileExtension = Path.GetExtension(formFile.FileName);
            uploadedFile.FileContent = buffer;
            db1.Add(uploadedFile);
            db1.SaveChanges();
            
        }


        public void FileDownload()
        { 
        
        }

        public void FileUpload()
        {

        }
        /*  public IndexModel(ILogger<IndexModel> logger)
          {
              _logger = logger;
          }*/

     /*
     @foreach(var audio in Model.Audios)-->
    {
        <tr>
            <td>@audio.Id</td>
            <td>@audio.Name</td>
        </tr>
    }
    */

    }

}
