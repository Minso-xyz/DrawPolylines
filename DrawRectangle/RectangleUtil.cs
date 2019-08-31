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
            Document doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor edt = doc.Editor;

            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                try
                {
                    doc.LockDocument();
                    BlockTable bt = trans.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                    BlockTableRecord btr = trans.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;

                    // Derive the lower right corner based on the insertion point
                    Point3d lrPt = PolarPoints(insPt, DegreesToRadians(0), width);

                    // Derive the upper right corner based on the lower right corner
                    Point3d urPt = PolarPoints(lrPt, DegreesToRadians(90), height);

                    // Derive the upper left corner based on the insertion point
                    Point3d ulPt = PolarPoints(insPt, DegreesToRadians(90), height);

                    // Draw the LWPolyline
                    Polyline pl = new Polyline();
                    pl.AddVertexAt(0, new Point2d(insPt.X, insPt.Y), 0, 0, 0);
                    pl.AddVertexAt(1, new Point2d(lrPt.X, lrPt.Y), 0, 0, 0);
                    pl.AddVertexAt(2, new Point2d(urPt.X, urPt.Y), 0, 0, 0);
                    pl.AddVertexAt(3, new Point2d(ulPt.X, ulPt.Y), 0, 0, 0);
                    pl.Closed = true;

                    btr.AppendEntity(pl);
                    trans.AddNewlyCreatedDBObject(pl, true);
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

        private Point3d PolarPoints(Point3d pPt, double dAng, double dDist)
        {
            return new Point3d(pPt.X + dDist * Math.Cos(dAng),
                               pPt.Y + dDist * Math.Sin(dAng),
                               pPt.Z);
        }

        private double DegreesToRadians(double degrees)
        {
            double radians = (Math.PI / 180) * degrees;
            return radians;
        }

    }
}
