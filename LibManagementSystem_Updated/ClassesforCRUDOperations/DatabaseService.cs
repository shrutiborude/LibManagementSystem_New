using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LibManagementSystem_Updated.Models
{
    public class DatabaseService<T> where T : class
    {
        private readonly MyDbContext _context;
        private readonly DbSet<T> _dbSet;

        
        public DatabaseService(MyDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = _context.Set<T>();
        }

        // Get all records
        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        // Add a new entity
        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        // Update an existing entity
        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // Delete an entity
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        // Find an entity by primary key
        public T GetById(object id)
        {
            return _dbSet.Find(id);
        }
    }
}
