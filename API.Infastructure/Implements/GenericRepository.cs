﻿using API.Core.DbModels;
using API.Core.Interfaces;
using API.Infastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Infastructure.Implements
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
    {
        private readonly StoreContext _context;

        public GenericRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return (await _context.Set<T>().FindAsync(id))!;  
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        { 
            return await _context.Set<T>().ToListAsync();
        }
    }
}
