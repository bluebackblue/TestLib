

/** BlueBack.TestLib.Samples.ActionDirect
*/
namespace BlueBack.TestLib.Samples.ActionDirect
{
	/** Action_SealedClassWithVirtual_Base
	*/
	public abstract class Action_SealedClassWithVirtual_Base
	{
		public virtual void Do(ref long a_value){}
	}

	/** Action_SealedClassWithVirtual
	*/
	public sealed class Action_SealedClassWithVirtual :  Action_SealedClassWithVirtual_Base
	{
		/** Do
		*/
		public override void Do(ref long a_value)
		{
			a_value++;
		}
	}
}

