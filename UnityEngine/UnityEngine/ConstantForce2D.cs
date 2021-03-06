using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequireComponent(typeof(Rigidbody2D))]
	public sealed class ConstantForce2D : PhysicsUpdateBehaviour2D
	{
		public Vector2 force
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_force(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_force(ref value);
			}
		}

		public Vector2 relativeForce
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_relativeForce(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_relativeForce(ref value);
			}
		}

		public extern float torque
		{
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_force(out Vector2 value);

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_force(ref Vector2 value);

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_relativeForce(out Vector2 value);

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_relativeForce(ref Vector2 value);
	}
}
