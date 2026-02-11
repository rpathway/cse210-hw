using System;

/*
 * Exceeding requirements:
 *
 * Level System:
 *   - Players gain levels every 1000 points
 *   - Rank names for each level
 *   - Displays current level and rank with score
 *   - Level up notification when player reaches new level
 *
 * User Experience:
 *   - Clear formatted display of player progress
 *   - Celebratory messages when recording events
 *   - Level up celebration messages
 *   - Better visual organization of menu and goals
 *
 * Error Handling:
 *   - Validates file existence before loading
 *   - Checks for already completed goals
 *   - Handles invalid menu choices
 *
 * The program adds meaningful progression beyond just a point system,
 * giving players a sense of advancement through ranks that correspond to
 * their spiritual journey. The rank names reflect the eternal nature of
 * the quest, progressing from a humble beginning to celestial achievement.
 */

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}