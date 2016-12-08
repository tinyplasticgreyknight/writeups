public class Widget2 : IWidget {
	private readonly DatabaseGrommit attachedGrommit;
	public IGrommit AttachedGrommit {
		get { return attachedGrommit; }
	}

	public Widget2() {
		attachedGrommit = new DatabaseGrommit(0, DatabasePool.Get());
	}

	public uint GetSize() {
		return AttachedGrommit.GetLength();
	}

	// ... much further down the file ...

	public void ApplyPlumbus(IPlumbus plumbus) {
		uint newSize = plumbus.Radius;
		attachedGrommit.SetLength(newSize);
	}
}
