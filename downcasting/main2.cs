public class Program {
	public static void Main(string[] args) {
		var widget = new Widget2();
		var plumbus = new Plumbus(3);

		Assert.AreEqual(0, widget.AttachedGrommit.GetLength());
		Assert.AreEqual(0, widget.GetSize());

		widget.ApplyPlumbus(plumbus);

		Assert.AreEqual(3, widget.AttachedGrommit.GetLength());
		Assert.AreEqual(3, widget.GetSize());
	}
}
