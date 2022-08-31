

/** BlueBack.TestLib.Samples.ActionDirect
*/
namespace BlueBack.TestLib.Samples.ActionDirect
{
	/** Action_SealedClassWithOtherAbstract
	*/
	public sealed class Action_SealedClassWithOtherAbstract :  Action_SealedClassWithOtherAbstract_Base
	{
		/** Do
		*/
		public void Do(ref long a_value)
		{
			a_value++;
		}

		/** Do
		*/
		public override void DoOther(ref long a_value)
		{
			a_value++;
		}
	}
}

