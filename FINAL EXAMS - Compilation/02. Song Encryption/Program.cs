using System;
using System.Linq;
using System.Text;

namespace _02._Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                var tokens = command.Split(':');
                var artist = tokens[0].ToCharArray();
                var song = tokens[1].ToCharArray();
                if (CheckArtistIsAvaible(artist) && CheckSongIsAvaible(song))
                {
                    var key = artist.Length;
                    Console.WriteLine($"Successful encryption: {EncryptArtist(artist, key)}@{EncryptArtist(song, key)}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        static string EncryptArtist(char[] artist, int key)
        {

            var encryptedArtist = string.Empty;
            for (int i = 0; i < artist.Length; i++)
            {
                if (artist[i] == ' ' || artist[i] == '\'')
                {
                    encryptedArtist += artist[i];
                    continue;
                }
                if (artist[i] + (char)key > 'z')
                {
                    var tempKey = (int)(artist[i]) + key - 26;
                    artist[i] = (char)(tempKey);
                    encryptedArtist += artist[i];
                    continue;
                }

                if (artist[i] + (char)key > 'Z' && char.IsUpper(artist[i]))
                {
                    int tempKey = (int)(artist[i]) + key - 26;
                    artist[i] = (char)(tempKey);
                    encryptedArtist += artist[i];

                    continue;

                }
                artist[i] += (char)key;
                encryptedArtist += artist[i];
            }
            return encryptedArtist;
        }

        static char[] EncryptSong(char[] song)
        {
            return song;
        }

        static bool CheckSongIsAvaible(char[] song)
        {
            for (int i = 0; i < song.Length; i++)
            {
                if (song[0] >= 'A' && song[0] <= 'Z')
                {
                    continue;
                }

                if (song[i] == ' ')
                {
                    continue;

                }
                if (song[0] < 'A' || song[0] > 'Z')
                {

                    return false;
                }
            }
            return true;

        }
        static bool CheckArtistIsAvaible(char[] artist)
        {
            if (artist[0] >= 'A' && artist[0] <= 'Z')
            {
                for (int i = 1; i < artist.Length; i++)
                {
                    if (artist[i] == ' ' || artist[i] == '\'')
                    {
                        continue;
                    }
                    if (artist[i] < 'a' || artist[i] > 'z')
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
