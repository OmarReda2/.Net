﻿using Demo.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly MVCAppContext _context;

        public GenericRepository(MVCAppContext context)
        {
            _context = context;
        }
        public async Task<int> Add(T item)
        {
            _context.Set<T>().Add(item);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(T item)
        {
            _context.Set<T>().Remove(item);
            return await _context.SaveChangesAsync();
        }

        public async Task<T> Get(int? id)
        => await _context.Set<T>().FindAsync(id);

        public async Task<IEnumerable<T>> GetAll()
        => await _context.Set<T>().ToListAsync();

        public async Task<int> Update(T item)
        {
            _context.Set<T>().Update(item);
            return await _context.SaveChangesAsync();
        }
    }
}
