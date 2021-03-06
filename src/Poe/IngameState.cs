using PoeHUD.ExileBot;
using PoeHUD.Poe.UI;

namespace PoeHUD.Poe
{
	public class IngameState : RemoteMemoryObject
	{
		public Camera Camera
		{
			get
			{
				return base.GetObject<Camera>(this.address + 0x15AC + Offsets.IgsOffset - Offsets.IgsDelta);
			}
		}
		public float CurrentZoomLevel
		{
			get
			{
				return this.m.ReadFloat(this.address + 0x1694 + Offsets.IgsOffset - Offsets.IgsDelta);
			}
			set
			{
				this.m.WriteFloat(this.address + 0x1694 + Offsets.IgsOffset - Offsets.IgsDelta, value);
			}
		}
		public IngameData Data
		{
			get
			{
				return base.ReadObject<IngameData>(this.address + 0x138 + Offsets.IgsOffset);
			}
		}
		public bool InGame
		{
			get
			{
				return this.m.ReadInt(this.address + 0x138 + Offsets.IgsOffset) != 0 && this.ServerData.IsInGame;
			}
		}
		public ServerData ServerData
		{
			get
			{
				return base.ReadObject<ServerData>(this.address + 0x13C + Offsets.IgsOffset);
			}
		}
		public IngameUIElements IngameUi
		{
			get
			{
				return base.ReadObject<IngameUIElements>(this.address + 0x5E8 + Offsets.IgsOffset);
			}
		}
		public Element UIRoot
		{
			get
			{
				return base.ReadObject<Element>(this.address + 0xC0C + Offsets.IgsOffset);
			}
		}
		public Element UIHover
		{
			get
			{
				return base.ReadObject<Element>(this.address + 0xC1C + Offsets.IgsOffset);
			}
		}
		public int EntityLabelMap
		{
			get
			{
				return this.m.ReadInt(this.address + 68, new int[]
				{
					2528
				});
			}
		}
	}
}
