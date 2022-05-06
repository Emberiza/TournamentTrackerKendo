using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentLibrary.Models;

namespace TournamentLibrary
{
	public interface IPrizeRequester
	{
		void PrizeComplete(PrizeModel model);
	}
}
