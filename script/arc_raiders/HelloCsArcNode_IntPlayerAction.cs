using Godot;
using System;

namespace Eloi.HelloCsArc
{
public partial class HelloCsArcNode_IntPlayerAction : Node
	{


		[Signal]
		public delegate void OnIntegerActionRequestedEventHandler(int actionRequested);
		
		[Signal]
		public delegate void OnIntegerActionRequestedWithDelayInMillisecondsEventHandler(int actionRequested, int delayInMilliseconds);

		[Export] public ArcRaidersIntegerActionEnum _key_move_forward = ArcRaidersIntegerActionEnum.MovingForward;
		[Export] public ArcRaidersIntegerActionEnum _key_move_backward = ArcRaidersIntegerActionEnum.MovingBackward;
		[Export] public ArcRaidersIntegerActionEnum _key_move_left = ArcRaidersIntegerActionEnum.MovingLeft;
		[Export] public ArcRaidersIntegerActionEnum _key_move_right = ArcRaidersIntegerActionEnum.MovingRight;


		public void PressKey(ArcRaidersIntegerActionEnum keyToPress)
		{
			EmitSignal(nameof(OnIntegerActionRequestedEventHandler), Convert.ToInt32(keyToPress));
		}

		public void ReleaseKey(ArcRaidersIntegerActionEnum keyToRelease)
		{
			EmitSignal(nameof(OnIntegerActionRequestedEventHandler), -(int)keyToRelease);
		}


		
	}
}
