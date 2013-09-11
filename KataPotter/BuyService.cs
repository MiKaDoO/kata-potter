using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataPotter
{
	public class BuyService
	{
		private Dictionary<int, int> reductions = new Dictionary<int, int>() { { 1, 0 }, { 2, 5 }, { 3, 10 }, { 4, 20 }, { 5, 25 } };

		public float CalculatePrice(List<string> card)
		{
			float res = 0;

			List<int> sets = CalculateSets(card.GroupBy(s => s).Select(s => s.Count()).ToList());

			if (sets.Any(i => i == 5) && sets.Any(i => i == 3))
			{
				int min = sets.Where(i => i == 3 || i == 5).GroupBy(i => i).Select(i => i.Count()).Min();

				for (int cpt = 0; cpt < min; cpt++)
				{
					sets.Remove(3);
					sets.Add(4);
					sets.Remove(5);
					sets.Add(4);
				}
			}

			foreach (var set in sets)
			{
				res += ((set * 8F) - reductions[set] * (set * 8F) / 100F);
			}

			return res;
		}

		private List<int> CalculateSets(List<int> card)
		{
			List<int> res = new List<int>();

			if (card.Any(i => i > 0))
			{
				res.Add(card.Count(i => i > 0));

				res.AddRange(CalculateSets(card.Where(i => i > 0).Select(i => i - 1).ToList()));
			}

			return res;
		}
	}
}
