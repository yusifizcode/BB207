using Core.DataAccessLayer;
using Core.Models;
using Core.Services.Abstracts;

namespace Core.Services.Concretes
{
    public class CommentService : ICommentService
    {
        public void AddComment(Comment comment)
        {
            if (comment == null) throw new NullReferenceException("Comment null ola bilmez!");

            if (comment.UserId == null || comment.BlogId == null)
                throw new NullReferenceException("UserId ve ya BlogId null ola bilmez!");

            Blog blog = AppDb.Blogs.FirstOrDefault(blog => blog.Id == comment.BlogId);
            User user = AppDb.Users.FirstOrDefault(user => user.Id == comment.UserId);

            if (user == null || blog == null)
                throw new NullReferenceException("User ve ya Blog yoxdur!");

            blog.Comments.Add(comment);
            user.Comments.Add(comment);

            AppDb.Comments.Add(comment);
        }

        public List<Comment> GetCommentsByBlogId(int? blogId)
        {
            if (blogId == null) throw new NullReferenceException("blogId null ola bilmez!");
            Blog blog = AppDb.Blogs.FirstOrDefault(blog => blog.Id == blogId);

            if (blog == null) throw new NullReferenceException("Blog yoxdur!");

            return blog.Comments;
        }
    }
}
