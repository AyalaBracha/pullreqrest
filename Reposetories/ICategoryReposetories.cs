﻿using Entities;

namespace Reposetories
{
    public interface ICategoryReposetories
    {
        Task<List<Category>> Get();

    }
}