public class Program {
	public static void Main(string[] args) {
		var widget = new Widget1();

		Assert.AreEqual(0, widget.AttachedGrommit.GetLength());
		Assert.AreEqual(0, widget.GetSize());
	}
}
