namespace Cryogenic.AdgPlayer.Ui.Tests.Services;

using Cryogenic.AdgPlayer.Ui.Services;
using Cryogenic.AdgPlayer.Ui.ViewModels;

using System.IO;

using Xunit;

/// <summary>Unit tests for <see cref="FileSystemAdgSongCatalog"/>.</summary>
public sealed class FileSystemAdgSongCatalogTests {
	/// <summary>Missing directories produce an empty catalog (no exception).</summary>
	[Fact]
	public void Enumerate_MissingDirectory_ReturnsEmpty() {
		// Arrange
		string missing = Path.Combine(Path.GetTempPath(), "cryogenic-adg-missing-" + Path.GetRandomFileName());
		FileSystemAdgSongCatalog catalog = new(missing);

		// Act
		System.Collections.Generic.IReadOnlyList<AdgBrowserItem> items = catalog.Enumerate();

		// Assert
		Assert.Empty(items);
	}

	/// <summary>Only files matching the <c>.UNHSQ</c> extension are returned.</summary>
	[Fact]
	public void Enumerate_FiltersByUnhsqExtension() {
		// Arrange
		string folder = Path.Combine(Path.GetTempPath(), "cryogenic-adg-cat-" + Path.GetRandomFileName());
		Directory.CreateDirectory(folder);
		try {
			File.WriteAllBytes(Path.Combine(folder, "ARRAKIS_AGD.UNHSQ"), new byte[] { 1, 2, 3 });
			File.WriteAllBytes(Path.Combine(folder, "README.TXT"), new byte[] { 9 });
			FileSystemAdgSongCatalog catalog = new(folder);

			// Act
			System.Collections.Generic.IReadOnlyList<AdgBrowserItem> items = catalog.Enumerate();

			// Assert
			Assert.Single(items);
			Assert.Equal("ARRAKIS_AGD.UNHSQ", items[0].FileName);
			Assert.Equal(3, items[0].SizeBytes);
		} finally {
			Directory.Delete(folder, recursive: true);
		}
	}
}