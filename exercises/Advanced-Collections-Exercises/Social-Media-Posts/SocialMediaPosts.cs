using System;
using System.Collections.Generic;
using System.Linq;

namespace Social_Media_Posts
{
    public class SocialMediaPosts
    {
        public static void Main()
        {   //        postNamne     commentator,commentsList
            Dictionary<string, Dictionary<string, List<string>>> posts = new Dictionary<string, Dictionary<string, List<string>>>();
            //       postName,numberOfLikes
            Dictionary<string, int> likes = new Dictionary<string, int>();
            //       postName,numberOfDislikes
            Dictionary<string, int> dislikes = new Dictionary<string, int>();
            string inputLine = String.Empty;
            while (inputLine != "drop the media")
            {
                inputLine = Console.ReadLine();
                if (inputLine == "drop the media") continue;
                string[] tokens = inputLine.Split(' ');
                string command = tokens[0];
                switch (command)
                {
                    case "post":
                        Post(posts, tokens);
                        break;
                    case "comment":
                        CommentPost(posts, tokens, inputLine);
                        break;
                    case "like":
                        LikePost(likes, tokens);
                        break;
                    case "dislike":
                        Dislike(dislikes, tokens);
                        break;
                }
            }
            PrintAllPosts(posts, likes, dislikes);
        }

        public static void PrintAllPosts(Dictionary<string, Dictionary<string, List<string>>> posts, Dictionary<string, int> likes, Dictionary<string, int> dislikes)
        {
            foreach (var post in posts)
            {
                int numberOfLikes = 0;
                int numberOfDislikes = 0;
                if (likes.ContainsKey(post.Key))
                {
                    numberOfLikes = likes[post.Key];
                }
                if (dislikes.ContainsKey(post.Key))
                {
                    numberOfDislikes = dislikes[post.Key];
                }
                Console.WriteLine($"Post: {post.Key} | Likes: {numberOfLikes} | Dislikes: {numberOfDislikes}");
                var comments = post.Value;
                if (comments.Count > 0)
                {
                    Console.WriteLine($"Comments:");
                    foreach (var comment in comments)
                    {
                        foreach (var str in comment.Value)
                        {
                            Console.WriteLine($"*  {comment.Key}: {str}");
                        }
                    }
                }
                if (comments.Count == 0)
                {
                    Console.WriteLine("Comments:");
                    Console.WriteLine("None");
                }

            }
        }

        public static void Dislike(Dictionary<string, int> dislikes, string[] tokens)
        {
            string postName = tokens[1];
            if (!dislikes.ContainsKey(postName))
            {
                dislikes[postName] = 0;
            }
            dislikes[postName]++;
        }

        public static void LikePost(Dictionary<string, int> likes, string[] tokens)
        {
            string postName = tokens[1];
            if (!likes.ContainsKey(postName))
            {
                likes[postName] = 0;
            }
            likes[postName]++;
        }

        public static void CommentPost(Dictionary<string, Dictionary<string, List<string>>> posts, string[] tokens, string inputLine)
        {
            string postName = tokens[1];
            string commentator = tokens[2];
            int len = tokens[0].Length + tokens[1].Length + tokens[2].Length + 3;
            var comment = inputLine.Substring(len);

            if (posts.ContainsKey(postName))
            {
                var comments = new List<string>();
                comments.Add(comment);
                posts[postName].Add(commentator, comments);
            }

        }

        public static void Post(Dictionary<string, Dictionary<string, List<string>>> posts, string[] tokens)
        {
            string postName = tokens[1];
            posts[postName] = new Dictionary<string, List<string>>();

        }
    }
}
