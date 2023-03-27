using System;
using System.Collections.Generic;

namespace YouTube
{
  class Video
  {
    public string Title { get; private set; }

    public string Author { get; private set; }

    public int Length { get; private set; }

    public List<Comment> Comments { get; private set; }

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