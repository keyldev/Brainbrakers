﻿using Brainbrakers.API.Repository.Interfaces;
using Brainbrakers.API.Services.Interfaces;
using podcast_api.Data;

namespace podcast_api.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ICategoriesRepository _categoriesRepository;
        
        public CategoriesService(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }


        public List<string> GetAllCategories()
        {
            return null;

            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    var categories = db.Categories.ToList();
            //    if (categories.Any())
            //        return categories.Select(c => c.CategoryName).ToList();
            //    else return null;
            //}

        }

        public List<string> GetAllKeywords()
        {
            return null;

            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    var keywords = db.Keywords.ToList();
            //    if (keywords.Any())
            //        return keywords.Select(k => k.Keyword).ToList();
            //    else return null;
            //}
        }


    }
}
