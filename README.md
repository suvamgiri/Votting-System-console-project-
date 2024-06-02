# Votting-System-console-project-
The Console Voting System is a simple application designed to simulate an electronic voting process. It allows users to cast votes for a set of candidates, ensures that each user can only vote once, and verifies voter eligibility based on predefined voting numbers.
Components

Classes:


Candidate: Represents a candidate in the election.

VotingUser: Represents a user eligible to vote, identified by a unique voting number.

Complete: Represents a completed vote, identified by the voter's number.

Collections:

List<Candidate> candidates: Holds the list of candidates participating in the election.

List<VotingUser> votingUsers: Holds the list of users who are eligible to vote.

List<Complete> numbers: Keeps track of the voting numbers of users who have already voted.

Functionality

Initialization:

The program begins by initializing lists for candidates, voting users, and completed votes.

It then prompts the administrator to enter the number of candidates and their names.

Voting Process:

The program enters a loop where it continuously allows users to vote.

It displays a list of candidates.

It prompts the user to select a candidate by entering the candidate's number.

It prompts the user to enter their unique voting number.

Vote Verification:

The system checks if the user has already voted by looking up their voting number in the numbers list.

If the user has already voted, it informs the user and does not allow another vote.

If the user has not voted, it checks if the user's voting number is valid (i.e., if it exists in the votingUsers list).

If the voting number is valid, it records the vote by adding the number to the numbers list and thanks the user for their vote.

If the voting number is invalid, it informs the user that they are not eligible to vote.

Looping for Continuous Voting:

The program continues to prompt for votes in an infinite loop, allowing multiple users to vote one after the other.

To exit the loop and end the program, an exit condition can be implemented (e.g., a specific command or after a certain number of votes).
