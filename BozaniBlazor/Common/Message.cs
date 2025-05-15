namespace BozaniBlazor.Common;

public sealed record Message(string Text, Severity Severity)
{
	public static Message Information(string text) => new(text, Severity.Information);
	public static Message Success(string text) => new(text, Severity.Success);
	public static Message Warning(string text) => new(text, Severity.Warning);
	public static Message Danger(string text) => new(text, Severity.Danger);

}