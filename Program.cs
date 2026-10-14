using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeClient youtube = new();

string path = Environment.CurrentDirectory;
string url = args[0];

if (args.Contains("-d"))
{
    int pathIndex = args.IndexOf("-d") + 1;
    path = Path.Combine([path, args[pathIndex]]);
    if (!Path.Exists(path))
    {
        Directory.CreateDirectory(path);
    }
}

var video = await youtube.Videos.GetAsync(url);
string directory = $"{path}/{video.Title}.mp4";

await youtube.Videos.DownloadAsync(url, directory);