using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace class_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solution 1
            /*var stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine("The recorded duration is {0}", stopwatch.GetDuration());
            Console.ReadLine();*/

            // Solution 2
            var post = new Post();
            post.Title = "Hello";
            post.Description = "World!";
            
            Console.WriteLine("Title: {0}\nDescription: {1}\nCreated At:{2}\nUp-vote: {3}\nDown-vote: {4}",post.Title,post.Description,post.Created_at,post.UpVote,post.DownVote);
            Console.ReadLine();

            post.UpVotting();
            post.DownVotting();
            Console.WriteLine("Up-vote: {0}\nDown-vote: {1}",post.UpVote,post.DownVote);
            Console.ReadLine();
        }
    }

    class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;

        public void Start()
        {
            try
            {
                Console.WriteLine(_startTime);
                if (_startTime != default(DateTime))
                {
                    throw new InvalidOperationException("You have pressed a start button twice.");
                }
                else
                {
                    Console.WriteLine("Stopwatch started");
                    _startTime = DateTime.Now;
                    Console.ReadLine();
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
                Console.ReadLine();

            }
            
            
        }

        public void Stop()
        {
            try
            {
                if (_startTime == default(DateTime) || _stopTime != default(DateTime))
                {
                    throw new InvalidOperationException("You have either pressed a stop button twice or have not pressed a start button");

                }
                else
                {
                    Console.WriteLine("Stopwatch stopped");
                    _stopTime = DateTime.Now;
                    Console.ReadLine();
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
            

        }

        public TimeSpan GetDuration()
        {
            return _stopTime.Subtract(_startTime);
            
        }
    }

    class Post
    {
        private string _title;
        private string _description;
        private readonly DateTime _created_at = DateTime.Now;
        private int _upVote;
        private int _downVote;

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Created_at
        {
            get { return _created_at; }
        }

        public int UpVote
        {
            get { return _upVote; }
        }

        public int DownVote
        {
            get { return _downVote; }
        }

        public void UpVotting()
        {
            _upVote += 1;
        }

        public void DownVotting()
        {
            _downVote += 1;
        }
    }
}
