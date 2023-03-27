using System;
using System.Collections.Generic;

namespace YouTube
{
  class Video
  {
    public string Title { get; set; }

    public string Author { get; set; }

    public int Length { get; set; }

    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
      Title = title;
      Author = author;
      Length = length;
      Comments = new List<Comment>();
    }

    public void addComment(Comment comment)
    {
      // Comments.Add(comment);
      this.Comments.Add(comment);
    }

    public void addComments(List<Comment> comments)
    {
      // Comments.Add(comment);
      this.Comments.AddRange(comments);
    }

    public int getNumComments()
    {
      return Comments.Count;
    }

  }
}