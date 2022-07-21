using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
	class Program {
		static void Main(string[] args) {
			var songs = new Song[] {
				new Song("悪魔の子", "ヒグチアイ", 230),
				new Song("ドライフラワー", "優里", 285),
				new Song("一途", "King Gnu", 190)
			};
			PrintSong(songs);

			var lists = new List<Song>();
			lists.Add(new Song("悪魔の子", "ヒグチアイ", 230));
			lists.Add(new Song("ドライフラワー", "優里", 285));
			lists.Add(new Song("一途", "King Gnu", 190));

			PrintSong(lists);
		}
		static void PrintSong(IEnumerable<Song> songs) {
			foreach (var song in songs) {
				Console.WriteLine("{0}, {1}, {2:m\\:ss}",
					song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));
			}
		}
	}
}
