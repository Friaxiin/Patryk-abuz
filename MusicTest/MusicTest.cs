using konsola;
namespace MusicTest

{
    public class MusicTest
    {
        [Fact]
        public void GivenTxtFile_WhenTwoFilesWithSameContent_ThenReturnsSameResult()
        {
            //arrange
            List<Music> music = new List<Music>();
            List<Music> musicTest = new List<Music>();

            //act
            Methods.GetData("Data.txt");
            music = Methods.musics;

            Methods.GetData("DataTest.txt");
            musicTest = Methods.musics;

            //assert
            Assert.Equal(music, musicTest);

        }
    }
}