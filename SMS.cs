using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


class Program
{
	static void Main(string[] args)
	{
		string accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
		string authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");

		TwilioClient.Init(accountSid, authToken);

		var message = MessageResource.Create(
		body: "Hi there!",
		  from : new Twilio.Types.PhoneNumber("+15017122661"),
			 to : new Twilio.Types.PhoneNumber("+15558675310")
				  );

		Console.WriteLine(message.Sid);
	}
}
EXAMPLE JSON API RESPONSE
{
	"account_sid": "ACXXX",
	"api_version" : "2010-04-01",
	"body" : "Hi there!.How are you? This small project was created for MLH LHD: share 2021",
	"date_created" : "Thu, 30 Jul 2015 20:12:31 +0000",
	"date_sent" : "Thu, 30 Jul 2015 20:12:33 +0000",
	"date_updated" : "Thu, 30 Jul 2015 20:12:33 +0000",
	"direction" : "outbound-api",
	"error_code" : null,
	"error_message" : null,
	"from" : "+5615451",
	"messaging_service_sid" : null,
	"num_media" : "0",
	"num_segments" : "1",
	"price" : null,
	"price_unit" : null,
	"sid" : "SMXXX",
	"status" : "sent",
	"subresource_uris" : {
		"media": "/2021-03-01/Accounts/ACXXX/Messages/SMXX/Media.json"
	},
	"to" : "+2566224461",
	"uri" : "/2021-03-01/Accounts/ACXXX/Messages/SMXX.json"
}
