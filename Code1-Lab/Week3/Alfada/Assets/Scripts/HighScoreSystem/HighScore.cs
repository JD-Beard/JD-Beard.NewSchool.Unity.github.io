using System;



class HighScore : IComparable<HighScore>
	{
		



	public int Score { get; set; }

	public string Name  { get; set; }

	public DateTime Date { get; set; }

	public int ID  { get; set; }

	public HighScore(int id, int score, string name, DateTime date)
	{

		this.Score = score;
		this.Name = name;
		this.ID = id;
		this.Date = date;


	}


	public int CompareTo(HighScore other){

		//first > second -1
		//first > second 1 
		//first == second 0
		if (other.Score < this.Score) {

			return -1;

		} else if (other.Score > this.Score) {

			return 1;

		} else if (other.Date < this.Date) {

			return -1;

		} else if (other.Date > this.Date) {


			return 1;
		}

		return 0;

	}






	}


