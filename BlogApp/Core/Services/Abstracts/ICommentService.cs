using Core.Models;

namespace Core.Services.Abstracts
{
    public interface ICommentService
    {
        void AddComment(Comment comment);
        List<Comment> GetCommentsByBlogId(int? blogId);
    }
}
