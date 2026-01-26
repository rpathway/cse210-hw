using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("His Accidental Virus Took Down the World's Biggest Website🎙Darknet Diaries Ep. 61: Samy", "Jack Rhysider", 3671);
        video1.AddComment(new Comment("milkywayvividbeetnix", "It’s funny, I remember going to college when MySpace was just becoming a thing. People always said that Sam’s account was added to everyone accounts because he was the owner of MySpace and just automatically added himself to everyone’s account.\n\nMy how that story has come full circle almost 20 years later. 😂"));
        video1.AddComment(new Comment("Dimness4", "Why not just delete your profile? Woulds that just cause an error but something MySpace can see quicker and remove?"));
        video1.AddComment(new Comment("StubblyTake4", "I was totally hoping that the MySpace thing was going to have a major plot twist like... There was no way to reverse or stop the worm and was forced to give his profile over to Tom the creator of MySpace, and that's why everyone had tom as a friend on MySpace. I was totally anticipating that and was waiting for my mind to be blown. Still wild outcome but god that would have been a epic story."));
        video1.AddComment(new Comment("Fiscally5Tiger", "I exploited the “Samy” worm in my cybersecurity class. Really cool to hear from him."));

        Video video2 = new Video("How the Greatest Hacker Manipulated Everyone", "Newsthink", 1524);
        video2.AddComment(new Comment("Wick2Snowsuit", "That is... i dont know what to say even"));
        video2.AddComment(new Comment("Knoll7Scribing", "holy crap , our company hired this guy for security training and he was treated like he was famous, at the time im like why is this boring mandatory corperate training being marketed to us like we are mmeting a celebrity. now it makes sense."));
        video2.AddComment(new Comment("SnowcapSector8", "Conclusion Humans are the weakest link in cyber security breaches"));
        video2.AddComment(new Comment("PrototypeEntourage", "Please stop the adds."));

        Video video3 = new Video("Operation Aurora | HACKING GOOGLE | Documentary EP000", "Google", 1105);
        video3.AddComment(new Comment("WiredPacifism", "What's the song at 0:17?"));
        video3.AddComment(new Comment("MonasteryDesignate", "I'm surprised google creates documentaries."));
        video3.AddComment(new Comment("RumblingWater", "Why is this actually so entertaining????"));
        video3.AddComment(new Comment("SeverityHardcore", "Absolutely in-love with this series. This motivates me to continue studying harder for my cyber security bachelor's :P"));

        Video video4 = new Video("Snip3 Crypter/RAT Loader - DcRat MALWARE ANALYSIS", "John Hammond", 6124);
        video4.AddComment(new Comment("LecturerRibcage", "vim is the best"));
        video4.AddComment(new Comment("ShowplaceQuickstep", "@55:25 that string obfuscation is used to evade some \"simple\" string match detection :D"));
        video4.AddComment(new Comment("StoppageChili", "I'm late, but it seems the reason you weren't getting anything back on port 5900 is that it likely requires a TLS handshake based on what that network client was doing. Incredible video. So many full circle moments! It seems like the author got most of the support code from other projects and is modifying or enhancing it?\n\nGreat to see your approach. As it turns out, a ton of info was already out there regarding the codebase, but even so, it's a great tutorial to show how to approach reverse engineering these sorts of things without knowing about them in advance."));
        video4.AddComment(new Comment("OutputEastcoast2", "Who in the world can write all of that coding"));

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };

        foreach (Video video in videos)
        {
            video.DisplayVideoData();
        }
    }
}