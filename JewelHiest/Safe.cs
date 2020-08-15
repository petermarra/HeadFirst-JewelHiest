namespace JewelHiest
{
    class Safe
    {
        private Jewels contents = new Jewels();
        private string safeCombination = "1234";
        public Jewels Open(string combination)
        {
            if (combination == safeCombination)
            {
                return contents;
            }
            else
                return null;
        }

        public void PickLock(LockSmith lockpicker)
        {
            lockpicker.WriteDownCombination(safeCombination);
        }

    }
}
