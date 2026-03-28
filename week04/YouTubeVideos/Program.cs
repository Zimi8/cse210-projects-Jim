using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Xpeng P7 Review: The Future of Chinese EVs", "AutoTech Daily", 720);
        v1.AddComment(new Comment("Mark", "The autonomous driving features look amazing."));
        v1.AddComment(new Comment("Elena", "How does the range compare to other brands?"));
        v1.AddComment(new Comment("David", "I really like the interior design."));
        videos.Add(v1);

        Video v2 = new Video("Complete Guide to Solar Panels and Battery Storage", "Green Energy Hub", 950);
        v2.AddComment(new Comment("Alex", "Great explanation on battery capacity."));
        v2.AddComment(new Comment("Rachel", "Is it worth the investment for a small house?"));
        v2.AddComment(new Comment("Sam", "I'm planning my off-grid setup right now."));
        videos.Add(v2);

        Video v3 = new Video("Ultimate CPU Benchmark 2026: Intel vs AMD", "TechHardwarePro", 840);
        v3.AddComment(new Comment("Chris", "That single-core performance is crazy."));
        v3.AddComment(new Comment("Jordan", "Time to upgrade my gaming rig."));
        v3.AddComment(new Comment("Taylor", "Great benchmarks, very detailed."));
        v3.AddComment(new Comment("Morgan", "Does this run hot under full load?"));
        videos.Add(v3);

        foreach (Video video in videos)
        { 
            video.Display();
        }
    }
}