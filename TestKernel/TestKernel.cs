public class Test {
	public unsafe static void Main() {
		ushort *video = (ushort *) 0xB8000U;
		
		video[ 0] = (ushort) (0x0F00 | 'H');
		video[ 1] = (ushort) (0x0F00 | 'e');
		video[ 2] = (ushort) (0x0F00 | 'l');
		video[ 3] = (ushort) (0x0F00 | 'l');
		video[ 4] = (ushort) (0x0F00 | 'o');
		video[ 5] = (ushort) (0x0F00 | ' ');
		video[ 6] = (ushort) (0x0F00 | 'W');
		video[ 7] = (ushort) (0x0F00 | 'o');
		video[ 8] = (ushort) (0x0F00 | 'r');
		video[ 9] = (ushort) (0x0F00 | 'l');
		video[10] = (ushort) (0x0F00 | 'd');
		video[11] = (ushort) (0x0F00 | '!');
		
		while(true) {}
	}
}
