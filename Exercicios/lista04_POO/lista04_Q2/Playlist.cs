class Playlist
{
    private string name, description;
    private List<Song> songs = new List<Song>();
    private int qtd = 0;

    public Playlist(){}
    public Playlist(string name, string description){
        if (name.Length > 0) this.name = name; 
        if (description.Length > 0) this.description = description;
        if (name.Length == 0 || description.Length == 0) throw new ArgumentException("Valor Inválido!");
    }

    public void SetName(string name){
        if (name.Length > 0) this.name = name; else Console.WriteLine("Valor Inválido!");
        if (name.Length == 0) throw new ArgumentException("Valor Inválido!");
    }
    public void SetDescription(string description){
        if (description.Length > 0) this.description = description; else Console.WriteLine("Valor Inválido!");
        if (description.Length == 0) throw new ArgumentException("Valor Inválido!");
    }

    public string GetName(){
        return name;
    }
    public string GetDescription(){
        return description;
    }

    public void InsertSong(Song m){
        songs.Add(m);
        qtd++;
    }

    public List<Song> ListSong(){
        return songs;
    }

    public override string ToString(){
        return $"A Playlist Possui {qtd} Músicas! \n";
    }

}

class Song
{
    private string title, artist, album;

    public Song(string title, string artist, string album){
        if (title.Length > 0) this.title = title;
        if (artist.Length > 0) this.artist = artist;
        if (album.Length > 0) this.album = album;
        if (title.Length == 0 || artist.Length == 0 || album.Length == 0) throw new ArgumentException("Valor Inválido!");
    }
    public override string ToString(){
        return $"Música: {title} \nArtista: {artist} \nAlbum: {album} \n";
    }
}