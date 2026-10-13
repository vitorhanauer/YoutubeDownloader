using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeClient youtube = new();

string url = args[0];
var video = await youtube.Videos.GetAsync(url);
string directory = $"{Environment.CurrentDirectory}/{video.Title}.mp4";

await youtube.Videos.DownloadAsync(url, directory);