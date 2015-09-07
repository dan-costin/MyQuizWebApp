using System;
using System.Linq;
using System.Data.Entity;
using System.Linq.Expressions;

namespace MyQuiz.Repository
{
    public class RepositoryBase<T> : IDisposable
        where T : DbContext, new()
    {
        private T _DataContext;

        public virtual T DataContext
        {
            get
            {
                if (_DataContext == null)
                {
                    _DataContext = new T();
                    this.AllowSerialization = true;
                }
                return _DataContext;
            }
        }

        public virtual bool AllowSerialization
        {
            get
            {
                return _DataContext.Configuration.ProxyCreationEnabled;
            }
            set
            {
                _DataContext.Configuration.ProxyCreationEnabled = !value;
            }
        }

        public virtual Y Get<Y>(Expression<Func<Y, bool>> predicate) where Y : class
        {
            if (predicate != null)
            {
                using (DataContext)
                {
                    return DataContext.Set<Y>().Where(predicate).SingleOrDefault();
                }
            }
            else
            {
                throw new ApplicationException("Predicate value must be passed to Get<T>.");
            }
        }

        public virtual IQueryable<Y> GetList<Y>(Expression<Func<Y, bool>> predicate) where Y : class
        {
            try
            {
                return DataContext.Set<Y>().Where(predicate);
            }
            catch (Exception ex)
            {
                //Log error
            }
            return null;
        }

        public virtual IQueryable<Y> GetList<Y, TKey>(Expression<Func<Y, bool>> predicate,
            Expression<Func<Y, TKey>> orderBy) where Y : class
        {
            try
            {
                return GetList(predicate).OrderBy(orderBy);
            }
            catch (Exception ex)
            {
                //Log error
            }
            return null;
        }

        public virtual IQueryable<Y> GetList<Y, TKey>(Expression<Func<Y, TKey>> orderBy) where Y : class
        {
            try
            {
                return GetList<Y>().OrderBy(orderBy);
            }
            catch (Exception ex)
            {
                //Log error
            }
            return null;
        }

        public virtual IQueryable<Y> GetList<Y>() where Y : class
        {
            try
            {
                return DataContext.Set<Y>();
            }
            catch (Exception ex)
            {
                //Log error
            }
            return null;
        }

        public void Dispose()
        {
            if (DataContext != null) DataContext.Dispose();
        }
    }
}
