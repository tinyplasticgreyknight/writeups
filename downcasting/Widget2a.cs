public class Widget2 : IWidget {
	public IGrommit AttachedGrommit { get; }

	public Widget2() {
		AttachedGrommit = new DatabaseGrommit(0, DatabasePool.Get());
	}

	public uint GetSize() {
		return AttachedGrommit.GetLength();
	}

	// ... much further down the file ...

	public void ApplyPlumbus(IPlumbus plumbus) {
		uint newSize = plumbus.Radius;
		((DatabaseGrommit)AttachedGrommit).SetLength(newSize);
		// ^-- downcast! --^
	}
}
