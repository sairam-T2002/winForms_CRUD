namespace winForms_CRUD;

public static class Utils
{
    public static void SetPlaceholder( TextBox txtBox, string placeholder )
    {
        txtBox.Text = placeholder;
        txtBox.ForeColor = Color.Gray;

        txtBox.GotFocus += ( sender, e ) =>
        {
            if (txtBox.Text == placeholder)
            {
                txtBox.Text = "";
                txtBox.ForeColor = Color.Black;
            }
        };

        txtBox.LostFocus += ( sender, e ) =>
        {
            if (string.IsNullOrWhiteSpace(txtBox.Text))
            {
                txtBox.Text = placeholder;
                txtBox.ForeColor = Color.Gray;
            }
        };
    }
}
