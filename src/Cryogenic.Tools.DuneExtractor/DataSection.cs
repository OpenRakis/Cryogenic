namespace DuneExtractor;

public record DataSection {
	public string NameOfFile { get; set; }
	public int SizeOfFile { get; set; }
	public int OffsetOfFile { get; set; }

	public DataSection() {
		this.NameOfFile = "";
		this.SizeOfFile = 0;
		this.OffsetOfFile = 0;
	}
}