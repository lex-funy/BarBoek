using ClassLibrary.DAL.Context;
using ClassLibrary.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.BLL
{
    public class ClubRetRepository
    {
        IClubContext Context;

        public ClubRetRepository(IClubContext context)
        {
            Context = context;
        }
        public List<ClubModel> GetAll()
        {
            return Context.GetAll();
        }
        public ClubModel GetById(int id)
        {
            return Context.GetClubById(id);
        }

        public ClubModel GetClubByName(string name)
        {
            return Context.GetClubByName(name);
        }

        public int CreateClub(ClubModel club)
        {
            int id = 0;
            ResultCode code = ValidateClub(club);
            if (code == ResultCode.Ok)
                try
                {
                    id = Context.Insert(club);
                }
                catch (Exception ex)
                {
                    code = ResultCode.StorageFailure;
                }
            return id;
        }

        public ResultCode ValidateClub(ClubModel club)
        {
            ResultCode result = ResultCode.Fail;
            ClubModel existingClub = GetClubByName(club.Name);
            if (existingClub == null)
            {
                if (club.Name != "")
                    result = ResultCode.Ok;
                else
                    result = ResultCode.FailedInvalidData;
            }
            else
                result = ResultCode.FailedAlreadyExists;
            return result;
        }

        public void UpdateClub(ClubModel club)
        {
            Context.Update(club);
        }

        public void DeleteClub(int id)
        {
            Context.Delete(id);
        }
    }
}
