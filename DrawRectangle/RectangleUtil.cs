using System;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.EditorInput;

namespace DrawRectangle
{
    public class RectangleUtil
    {
        [CommandMethod("ShowRectangleForm")]
        public void ShowRectangleForm()
        {
            RectangleForm rf = new RectangleForm();
            rf.Show();
        }

        public void DrawRectangle(double width, double height, Point3d insPt)
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor edt = doc.Editor;

            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                try
                {
                    doc.LockDocument();
                    BlockTable bt = trans.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                    BlockTableRecord btr = trans.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;

                    // Convert the insertionPoint to Point2d
                    Point2d insPt2d = new Point2d(insPt.X, insPt.Y);

                    // Derive the upper left corner based on the Insertion Point
                    Point2d ulPt = new Point2d(insPt.X, +insPt.Y + height);

                    // Derive the upper right corner based on the upper left corner
                    Point2d urPt = new Point2d(ulPt.X + width, ulPt.Y);

                    // Derive the lower right corner based on the insertion point
                    Point2d lrPt = new Point2d(insPt.X + width, insPt.Y);

                    // Draw the LWPolyline using the newly derived vertices
                    Polyline pl = new Polyline();                            
                    pl.AddVertexAt(0, insPt2d, 0, 0, 0);
                    pl.AddVertexAt(1, ulPt, 0, 0, 0);
                    pl.AddVertexAt(2, urPt, 0, 0, 0);
                    pl.AddVertexAt(3, lrPt, 0, 0, 0);
                    pl.Closed = true;

                    btr.AppendEntity(pl);
                    trans.AddNewlyCreatedDBObject(pl, true);

                    
                    string txt = width.ToString() + " x " + height.ToString();
                    //Point2d txtPt = new Point2d(insPt.X + (0.5 * width), insPt.Y + (0.5 * height));
                    Point3d txtPt = new Point3d(insPt.X + (0.5 * width), insPt.Y + (0.5 * height) ,0);
                    using (MText mtx = new MText())
                    {
                        mtx.Contents = txt;
                        mtx.Location = txtPt;

                        btr.AppendEntity(mtx);
                        trans.AddNewlyCreatedDBObject(mtx, true);
                    }
                    
                    trans.Commit();

                    edt.WriteMessage("Rectangle is drawn successfully!");
                    
                }
                catch (System.Exception ex)
                {
                    edt.WriteMessage("Error encountered: " + ex.Message);
                    trans.Abort();
                }
            }
        }
    }
}
