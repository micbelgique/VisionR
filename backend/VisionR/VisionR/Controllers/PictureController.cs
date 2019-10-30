using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VisionR.Model;

namespace VisionR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PictureController : ControllerBase
    {
        private readonly Context _dbContext;
        public PictureController(Context dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Image>> GetAllImages()
        {
            return await _dbContext.Images
                .Include(i =>i.VisionResult)
                    .ThenInclude(v => v.Adult)
                .Include(i => i.VisionResult)
                    .ThenInclude(v => v.Brands)
                .Include(i => i.VisionResult)
                    .ThenInclude(v => v.Categories)
                .Include(i => i.VisionResult)
                    .ThenInclude(v => v.Color)
                .Include(i => i.VisionResult)
                    .ThenInclude(v => v.Description)
                        .ThenInclude(d => d.Captions)
                .Include(i => i.VisionResult)
                    .ThenInclude(v => v.Faces)
                        .ThenInclude(f => f.FaceRectangle)
                .Include(i => i.VisionResult)
                    .ThenInclude(v => v.ImageType)
                .Include(i => i.VisionResult)
                    .ThenInclude(v => v.Metadata)
                .Include(i => i.VisionResult)
                    .ThenInclude(v => v.Objects)
                        .ThenInclude(o => o.Rectangle)
                .Include(i => i.VisionResult)
                    .ThenInclude(v => v.Tags)
                .ToListAsync();
        }

        [HttpPost]
        public async Task<bool> AddImage(Image image)
        {
            try
            {
                await _dbContext.Images.AddAsync(image);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}