using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarmUp.Model;

namespace WarmUp.Repository
{
    public class PostRepository
    {
        private readonly Context _context;
        public PostRepository(Context context)
        {
            _context = context;
        }
        public Post Create(Post post)
        {
            _context.Post.Add(post);
            _context.SaveChanges();
            return post;
        }
        public bool Edit(Post post)
        {
            _context.Post.Update(post);
            _context.SaveChanges();
            return true;
        }
        public Post GetById(int Id)
        {
            return _context.Post.Find(Id);
        }
        public IEnumerable<Post> GetAll()
        {
            return _context.Post.Where(x => x.Active);
        }
        public bool Delete(Post post)
        {
            post.Active = false;
            _context.Post.Update(post);
            _context.SaveChanges();
            return true;
        }
    }
}
