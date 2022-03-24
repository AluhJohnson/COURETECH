using Microsoft.AspNetCore.Mvc;
using PhoneNumberCountryCode.Model;
using System.Collections.Generic;
using System.Linq;

namespace PhoneNumberCountryCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Contact> Get(string phone)
        {

            IEnumerable<Contact> contacts = new List<Contact>();

            if (phone != null)
            {

                string result = phone.Substring(0, 3);

                if (result.Contains("234"))
                {
                    contacts = InitializeContact();
                    //contacts = contacts.Where(contacts => contacts.Country.First().CountryCode == result);
                    if (contacts.First().Country.First().CountryCode == result && contacts.First().number == phone)
                    {
                        contacts = contacts.Where(contacts => contacts.Country.First().CountryCode == result);
                        return contacts;
                    }
                    //contacts = contacts.Where(contacts => contacts.Country.First().CountryDetails.First().CountryCode == result);
                }
                //contacts = contacts.Where(contacts => contacts.CountryDetails.First().Country.First().CountryCode == phone);
                //contacts = contacts.Where(contacts => contacts.number == phone);
            }

            return contacts;
        }

        [NonAction]
        public List<Contact> InitializeContact()
        {
            List<Contact> contact = new List<Contact>()
            {
                new Contact() {
                    number = "2348033432323",
                    Country  = new List<Country>{
                        new Country
                        {
                            CountryId = 1, CountryCode = "234", CountryIso = "NG", Name= "Nigeria",
                            CountryDetails = new List<CountryDetail>
                            {
                                new CountryDetail
                                {
                                    CountryId =1, Operator = "MTN Nigeria", OperatorCode = "MTN NG"
                                },
                                new CountryDetail
                                {
                                    CountryId =1, Operator = "Airtel Nigeria", OperatorCode = "ANG"
                                },
                                new CountryDetail
                                {
                                    CountryId =1, Operator = "9 Mobile Nigeria", OperatorCode = "ETN"
                                },
                                new CountryDetail
                                {
                                    CountryId =1, Operator = "Globacom Nigeria", OperatorCode = "GLO NG"
                                }
                            }
                        }
                        //,
                        //new Country
                        //{
                        //    CountryId = 2, CountryCode = "233", CountryIso = "GH", Name= "Ghana",
                        //    CountryDetails = new List<CountryDetail>
                        //    {
                        //        new CountryDetail
                        //        {
                        //            CountryId = 2, Operator = "Vodafone Ghana", OperatorCode = "Vodafone GH"
                        //        },
                        //        new CountryDetail
                        //        {
                        //            CountryId = 2, Operator = "MTN Ghana", OperatorCode = "MTN Ghana"
                        //        },
                        //        new CountryDetail
                        //        {
                        //            CountryId = 2, Operator = "Tigo Ghana", OperatorCode = "Tigo Ghana"
                        //        }
                        //    }
                        //},
                        //new Country
                        //{
                        //    CountryId = 3, CountryCode = "229", CountryIso = "BN", Name= "Benin Republic",
                        //    CountryDetails = new List<CountryDetail>
                        //    {
                        //        new CountryDetail
                        //        {
                        //            CountryId = 3, Operator = "MTN Benin", OperatorCode = "MTN Benin"
                        //        },
                        //        new CountryDetail
                        //        {
                        //            CountryId = 3, Operator = "Moov Benin", OperatorCode = "Moov Benin"
                        //        }
                        //    }
                        //},
                        //new Country
                        //{
                        //    CountryId = 4, CountryCode = "225", CountryIso = "CIV", Name= "Côte d'Ivoire",
                        //    CountryDetails = new List<CountryDetail>
                        //    {
                        //        new CountryDetail
                        //        {
                        //            CountryId =1, Operator = "MTN Côte d'Ivoire", OperatorCode = "MTN CIV"
                        //        }
                        //    }
                        //}
                    }
                },


                new Contact() {
                    number = "2338033432323",
                    Country  = new List<Country>{
                        new Country
                        {
                            CountryId = 2, CountryCode = "233", CountryIso = "GH", Name= "Ghana",
                            CountryDetails = new List<CountryDetail>
                            {
                                new CountryDetail
                                {
                                    CountryId = 2, Operator = "Vodafone Ghana", OperatorCode = "Vodafone GH"
                                },
                                new CountryDetail
                                {
                                    CountryId = 2, Operator = "MTN Ghana", OperatorCode = "MTN Ghana"
                                },
                                new CountryDetail
                                {
                                    CountryId = 2, Operator = "Tigo Ghana", OperatorCode = "Tigo Ghana"
                                }
                            }
                        },
                    }
                },


                new Contact() {
                    number = "2298033432323",
                    Country  = new List<Country>{
                        new Country
                        {
                            CountryId = 3, CountryCode = "229", CountryIso = "BN", Name= "Benin Republic",
                            CountryDetails = new List<CountryDetail>
                            {
                                new CountryDetail
                                {
                                    CountryId = 3, Operator = "MTN Benin", OperatorCode = "MTN Benin"
                                },
                                new CountryDetail
                                {
                                    CountryId = 3, Operator = "Moov Benin", OperatorCode = "Moov Benin"
                                }
                            }
                        },
                    }
                },

                new Contact() {
                    number = "2258033432323",
                    Country  = new List<Country>{
                        new Country
                        {
                            CountryId = 4, CountryCode = "225", CountryIso = "CIV", Name= "Côte d'Ivoire",
                            CountryDetails = new List<CountryDetail>
                            {
                                new CountryDetail
                                {
                                    CountryId =1, Operator = "MTN Côte d'Ivoire", OperatorCode = "MTN CIV"
                                }
                            }
                        }
                    }
                }


            };
            return contact;
        }


    }
}
