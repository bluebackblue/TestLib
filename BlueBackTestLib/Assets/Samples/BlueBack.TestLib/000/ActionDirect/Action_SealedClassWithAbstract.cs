

/** BlueBack.TestLib.Samples.ActionDirect
*/
namespace BlueBack.TestLib.Samples.ActionDirect
{
	/** Action_SealedClassWithAbstract
	*/
	public sealed class Action_SealedClassWithAbstract :  Action_SealedClassWithAbstract_Base
	{
		/** Do
		*/
		public override void Do(ref long a_value)
		{
			a_value++;
		}
	}
}

