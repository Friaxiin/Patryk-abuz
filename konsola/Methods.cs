using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsola
{
    public static class Methods
    {
        static List<Music> musics = new List<Music>();


        /*********************************
        nazwa funkcji:          GetData
        opis funkcji:           funkcja pobiera dane z pliku, tworzy strukturę z podanych danych oraz dodaje ją do globalnej listy
        parametry:              path - ścieżka do pliku z danymi
        zwracany typ i opis:    brak
        autor:                  PESEL
        *********************************/

        public static void GetData(string path)
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                List<string> musicList = new List<string>();

                foreach (string line in lines)
                {
                    musicList.Add(line);
                }

                for (int i = 0; i < musicList.Count; i += 6)
                {
                    Music music = new Music()
                    {
                        artist = musicList[i],
                        album = musicList[i + 1],
                        songsNumber = int.Parse(musicList[i + 2]),
                        year = int.Parse(musicList[i + 3]),
                        downloadNumber = int.Parse(musicList[i + 4]),
                    };
                    musics.Add(music);
                }
            }
        }

        public static List<Music> DisplayData()
        {
            
        }
    }
}
