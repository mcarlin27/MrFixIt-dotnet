# Mr. Fix-It

#### _App created for Epicodus .NET Week 3 Independent project, using ASP.NET, with a focus on AJAX. 8/18/2017_

#### By **Marilyn Carlin**

## Description

_A web application for a company that connects workers with jobs, and allows users to post jobs they need doing. Authenticated users can also create a Worker profile that allows them to claim jobs._

## Program Specifications

| Description  | Input Example | Output Example |
| ------------- | ------------- | ------------- |
| User can register and log on  | "Register" or "Log In"  | User is navigated to appropriate site. |
| Registered users can create a Worker profile.  | "Create your worker profile"  | Form |
| User can add jobs to the jobs list  | "Add job"  | Form to add job |
| User can claim a job with an AJAX request  | "Claim Job"  | "Job has been claimed by you!" |
| A user can designate a job as active  | "Mark Active"  | "Job has been marked active." |
| A user may mark a job as complete  | "Mark Completed"  | "Job has been marked completed." |

## Setup/Installation Requirements

**Requirements**

If you do not have Visual Studio 2017, download [HERE](https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=Community&rel=15).

If you do not have SSMS, download [HERE](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms).

**Cloning From GitHub:** Download or clone project repository onto desktop from GitHub.

Open the project in Visual Studio.

**Migrations**
1. In Solution Explorer, right-click the project and choose 'Open in File Explorer' from the context menu.
2. Enter "cmd" in the address bar and press Enter.
3. Enter the following command in the command window:
  - dotnet ef database update
4. In VS, click IIS Express at the top of the window. Project should open in a new window in your default browser.

## Known Bugs

_No known bugs._

## Support and contact details

_Please contact Marilyn Carlin at marilyn.s.carlin@gmail.com with any questions, comments, or concerns_

## Technologies Used

**Languages:** HTML, CSS, C#, ASP.NET

**IDE:** Visual Studio 2017

**Database Management:** MySQL (SSMS)

### License

*MIT license Agreement*

Copyright (c) 2017 **_Marilyn Carlin_*
